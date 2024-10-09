class Bankomat:
    def __init__(self, name):
        self.name = name
        self.balance = 100

    def wyplac(self, amount):
        if amount > self.balance:
            return "Za mało środków na koncie"
        self.balance -= amount
        return self.balance

    def wplac(self, amount):
        self.balance += amount
        return self.balance

    def greeting(self):
        print(f'Welcome to the bank of Python, {self.name}!')
        print("Please select an option:")
        print("1. Deposit (deposit, dep)")
        print("2. Withdraw (withdraw, wd)")
        print("3. Check balance (balance, bal)")
        print("4. Exit (q, exit)")
    
    def __str__(self):
        return f'Imię: {self.name}\nStan konta: {self.balance}'

name = input("Jak masz na imię: ")

bankomat = Bankomat(name)
bankomat.greeting()

while True:
    action = input("> ")

    if action == '1':
        amount = int(input("Podaj ile chcesz wpłacic: "))
        bankomat.wplac(amount)
    elif action == '2':
        amount = int(input("Podaj ile chcesz wypłacić: "))
        bankomat.wyplac(amount)
    elif action == '3':
        print(bankomat)
    elif action == '4' or action == 'q':
        break
    else:
        print("Naczu się czytać")
