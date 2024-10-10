












class Owoc:
    def __init__(self, nazwa, kolor):
        self.nazwa = nazwa
        self.kolor = kolor
    
    def szczegoly(self):
        return f"Owoc: {self.nazwa}, Kolor: {self.kolor}"

moj_owoc = Owoc('banan', 'żółty')

print(moj_owoc.szczegoly())  # Wyświetli: Owoc: banan, Kolor: żółty

