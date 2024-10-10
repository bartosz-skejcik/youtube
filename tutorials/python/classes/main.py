








class Owoc:
    def __init__(self, nazwa):
        self.nazwa = nazwa

    def szczegoly(self):
        return f"Nazwa: {self.nazwa}"


banan = Owoc("banan")
jablko = Owoc("jablko")

print(banan.szczegoly())
print(jablko.szczegoly())
