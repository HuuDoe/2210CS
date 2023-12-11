var holes = document.querySelectorAll('.hole');
var scoreBoard = document.querySelector('.score');
var moles = document.querySelectorAll('.mole');
var setscore = document.getElementById('scores');
let lastHole;
let timeUp = false;
let score = 0;
var gametime=10000;


//create a function to make a random time for mole to pop from the hole
function randomTime(min, max) {
    return Math.round(Math.random() * (max - min) + min);
}

function randomHole(holes){
    const index  = Math.floor(Math.random() * holes.length);
    const hole = holes[index];

    //prevent same hole from getting the same number
    if (hole === lastHole){
        return randomHole(holes);
    }
    lastHole = hole;
    return hole;
}

function peep() {
    const time = randomTime(250, 1000); //get a random time to determine how long mole should peep
    const hole = randomHole(holes); //get the random hole from the randomHole function
    hole.classList.add('up'); //add the CSS class so selected mole can "pop up"
    setTimeout(() => {
        hole.classList.remove('up'); //make the selected mole "pop down" after a random time
        if(!timeUp) {
    
            peep();
        }
    }, time);
}
function setTimer() {
    let timer = prompt("Please enter desired game time in seconds", "10");
    if (timer != null) {
      gametime= parseInt(timer);
}}
function startGame() {
    scoreBoard.textContent = 0;
    timeUp = false;
    score = 0;
    peep();
    setTimeout(() => {
        timeUp = true;
        setscore.innerHTML+=("<p style='color: black;font-size:200%;margin:5px;'>" + scoreBoard.innerHTML + "</p>");
        console.log(scoreBoard.innerHTML);
        alert("Time's up!!!");
    }, (gametime*1000)) //show random moles for 5 seconds

}

function wack(e){
    if(!e.isTrusted) return; //** new thing I learned */
    score++;
    this.parentNode.classList.remove('up'); //this refers to item clicked
    scoreBoard.textContent = score;
}

moles.forEach(mole => mole.addEventListener('click', wack))

