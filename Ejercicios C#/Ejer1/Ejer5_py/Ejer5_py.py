
suma_total = 0.0
numerador = 45
denominador = 4

print("Fracciones generadas: ")

for i in range(60):
    
    print(f"{numerador}/{denominador}") 
    suma_total += numerador / denominador
    numerador -= 3
    denominador += 3

print("-" * 20)
print(f"La suma total de las 60 fracciones es: {suma_total:.4f}")
