
import random

frecuencias = [0] * 6

print("Simulando 50 lanzamientos...")

for _ in range(50):

    resultado = random.randint(1, 6)
    frecuencias[resultado - 1] += 1

print("\nResultados de frecuencia:")
for i in range(6):
    print(f"Cara {i + 1}: {frecuencias[i]} veces")