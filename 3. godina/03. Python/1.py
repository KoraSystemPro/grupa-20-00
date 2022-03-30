
def mnozenje(a, b, c):
    return a * b * c

def mnozi_listu(lista): # lista = [2, 3, 7, 1, 2, 3]
    proizvod = 1
    for i in lista:
        proizvod = proizvod * i
    return proizvod

# y = 2 + (3 * 2 * 6)
# y = 2 + mnozenje(3, 2, 6)
print(mnozi_listu([2, 3, 1, 2, 3, 3]))


lista_za_kupovinu = {
    "Hleb" : 2,
    "Mleko" : 2,
    "Jogurt" : 3,
    "Puter" : 1,
    "Koncentrat za caj" : 1,
    "Cokolada" : 7
}
# 2 x Hleb
# 2 x Mleko
# for item in lista_za_kupovinu:
#     print(str(lista_za_kupovinu[item]) + " x " + item)

lista_itema = [
    ("Hleb", 30, 49.99),
    ("Mleko", 100, 79.99),
    ("Jogurt", 30, 99.99),
    ("Zvake", 200, 65.99),
]
# for item in lista_itema:
#     print(item[0] + " : " + str(item[1] * item[2]))
for ime, kolicina, cena in lista_itema:
    print(ime + " - " + str(kolicina * cena))


def mnozi_parne(lista, parni=True):
    proizvod = 1
    for x in lista:
        if (parni == True) and (x % 2 == 0):
            proizvod = proizvod * x
        elif (parni == True) and (x % 2 != 0):
            continue
        else:
            proizvod = proizvod * x

    return proizvod

print(mnozi_parne([4, 3, 2, 3, 2]))   # 16
print(mnozi_parne([4, 3, 2, 3, 2], False))  # 16 * 9

# realan imaginaran
# x      i
# (5 + 3i) + (2 + 3i) = (7 + 6i)

class KompleksanBroj:
    def  __init__(self, r=0, i=0, stepen=1, plus=True):
        self.r = r
        self.i = i
        self.stepen = stepen
        self.plus = True

    def __str__(self):
        return str(self.r) + " + " + str(self.i) + "i"

    def saberi(self, kompleksan_broj):
        self.r = self.r + kompleksan_broj.r
        self.i = self.i + kompleksan_broj.i
    
    def pomnozi(self, kompleksan_broj):
        self.r = self.r

num1 = KompleksanBroj(2, 3)
print(num1)
num1.saberi(KompleksanBroj(5, 1))
print(num1)













