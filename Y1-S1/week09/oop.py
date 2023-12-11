class Person:
    def __init__(this, praname):
        this.name = praname
        
    def __repr__(self):
        return self.name

quang = Person('quang')

print(quang)