const search = document.getElementById('search'),
  submit = document.getElementById('submit'),
  random = document.getElementById('random'),
  mealsEl = document.getElementById('meals'),
  resultHeading = document.getElementById('result-heading'),
  single_mealEl = document.getElementById('single-meal');

// Search meal and fetch from API
function searchMeal(e) {
  // type is submit, but don't want to actually submit to a file
  e.preventDefault();

  // Clear single meal
  single_mealEl.innerHTML = '';

  // Get search term
  const term = search.value;

  // Check for empty
  if (term.trim()) {
    fetch(`https://www.themealdb.com/api/json/v1/1/search.php?s=${term}`)
      .then((res) => res.json())
      .then((data) => {
        resultHeading.innerHTML = `<h2>Search results for '${term}':</h2>`;

        if (data.meals === null) {
          resultHeading.innerHTML = `<p>No results.</p>`;
        } else {
          mealsEl.innerHTML = data.meals.map(
              (meal) => `
            <div class="meal">
              <img src="${meal.strMealThumb}" alt="${meal.strMeal}">
              <div class="meal-info" data-mealID="${meal.idMeal}">
                <h3 class="h4">${meal.strMeal}</h3>
              </div>
            </div>
          `
            )
            .join('');
        }
      });
    // Clear search text
    search.value = '';
  } else {
    alert('Please enter a search term');
  }
}

// Fetch meal by ID
function getMealById(mealID) {
  fetch(`https://www.themealdb.com/api/json/v1/1/lookup.php?i=${mealID}`)
    .then((res) => res.json())
    .then((data) => {
      const meal = data.meals[0];

      addMealToDOM(meal);
    });
}

// Fetch random meal
function getRandomMeal() {
  // Clear meals and heading
  mealsEl.innerHTML = '';
  resultHeading.innerHTML = '';

  fetch(`https://www.themealdb.com/api/json/v1/1/random.php`)
    .then((res) => res.json())
    .then((data) => {
      const meal = data.meals[0];

      addMealToDOM(meal);
    });
}
var calo;
function getNutrions(measure,name) {
  calo = 0;
  if (measure==null || name ==null){
    calo+=0;
    console.log(calo,"not counted");
  } else{
    var num = measure.match(/\d/g);
    if (num==null){
      var numb=0
    } else{
      num=num.join("");
      numb=parseInt(num);
      if (numb >=50){
        numb=numb/1000;
      }
    };
    
    console.log("number is ",typeof(numb),numb);
    var name1=name.replace(/\s/g,'%20');
    fetch(`https://api.edamam.com/api/nutrition-data?app_id=6793bfb8&app_key=c5d4a90d71e3728a62bb17fa30edb3e0&nutrition-type=cooking&ingr=1%20${name1}
    `)
      .then((res) => res.json())
      .then((data) => {

        var calo = data.calories*numb;
        totalCalo+=calo;
        document.getElementById('each').innerHTML +=("<p>"+name+" = "+calo.toFixed(2)+"</p>"); 
        document.getElementById('pls').innerHTML ="Total Calories: "+totalCalo.toFixed(2);
        console.log(calo," counted");
      });
      
      
      
    }
 
}

var totalCalo= 0;
// Add meal to DOM
function addMealToDOM(meal) {

  const ingredients = [];
  
  
  // Max of 20 ingredients
  for (let i = 1; i <= 20; i++) {
    if (meal[`strIngredient${i}`]) {
      console.log(meal[`strMeasure${i}`]);
      console.log(meal[`strIngredient${i}`]);
    
      (getNutrions((meal[`strMeasure${i}`]) ,(meal[`strIngredient${i}`]) ));
      
      ingredients.push(
        `${meal[`strIngredient${i}`]} - ${meal[`strMeasure${i}`]}`
      );
      
    } else {
      break;
    }
  }
  

  single_mealEl.innerHTML = `
    <div class="single-meal">
      <h1>${meal.strMeal}</h1>
      <img src="${meal.strMealThumb}" alt="${meal.strMeal}">
      
      <div class="main">
        <p>${meal.strInstructions}</p>
        <h2>Ingredients</h2>
        <ul>
          ${ingredients.map((ing) => `<li>${ing}</li>`).join('')}
        </ul>
      </div>
      <div class="single-meal-info">
        <p>Category: ${meal.strCategory}</p>
        <p id="cal1">Approx for each ingredient: </p>
        <li id="each"></li>
        <p id="pls">Total Calories: </p>
        
      </div>
    </div>
  `;
}

// Event listeners
submit.addEventListener('submit', searchMeal);
random.addEventListener('click', getRandomMeal);

mealsEl.addEventListener('click', (e) => {
  // path vs composedPath - https://stackoverflow.com/questions/39245488/event-path-is-undefined-running-in-firefox
  const path = e.path || (e.composedPath && e.composedPath());
  const mealInfo = path.find((item) => {
    if (item.classList) {
      return item.classList.contains('meal-info');
    } else {
      return false;
    }
  });

  if (mealInfo) {
    const mealID = mealInfo.getAttribute('data-mealid');
    getMealById(mealID);
  }
});
