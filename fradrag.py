class Fradrag:

    def __init__(self) -> None: # Her har vi constructoren med 1 parameter som er min_km
        # self.min_km: int = min_km # Her sætter vi self.min_km
        pass

    def calc_fradrag(self, km: float) -> float: #
        try:
            pris: float = 2.16 
            penge: float

            if km > 120:
                temp = km - 120
                penge = temp * 1.08
                km -= temp
            # print(f"km after: {km}")
            bropenge: float = self.bro()
            
            penge += (km - 24) * pris + bropenge 

            return penge
        except Exception:
            print(f"calc_fradrag Error: {Exception}")
            return -1

    def calc_km(self, km: float) -> float:
        try:
            km *= 2

            if km <= 24: # Hvis det indtastede kilometer * 2 er under eller equals self.min_km
                return 0 # Returner 0
            
            return km
        except Exception:
            print(f"calc_km Error: {Exception}")
            return -1
    
    def bro(self) -> float:
        type: int = int(input(f"[0] Ingen bro\n[1] Storebælt\n[2] Øresund\n"))

        if type == 0:
            return 0

        if type == 1:
            return 50 * 2
        
        return 110 * 2
    
    

class Print:

    def __init__(self) -> None: # Instantier klassen med 1 parameter som er min_km
        # self.min_km = min_km # Sæt self.min_km
        pass

    def calc_sum(self) -> float:
        km: float = float(input("Kilometer til arbejde: "))
        test = Fradrag() # Fradrag(self.min_km) Brug vores self.min_km som parameter til instatiering af fradragsklassen
        # print(test.min_km)
        total_km: float = test.calc_km(km)

        penge: int = test.calc_fradrag(total_km)
        return penge
    
    def print_money(self, penge: float) -> None:
        rounded = round(penge, 3)
        print(f"Penge tilbage: {rounded}kr")

# min_km = int(input("minimum kilometer: ")) # Få et minimum_kilometer som int
money = Print() # Print(min_km)
sum = money.calc_sum()
money.print_money(sum)



    