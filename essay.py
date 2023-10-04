import math

# Генерируем случайные данные для примера
import random

# Генерация случайных данных о покупках
def generate_random_data(num_samples):
    data = []
    for _ in range(num_samples):
        price = random.uniform(10, 200)  # случайная стоимость от 10 до 200
        quantity = random.randint(1, 10)  # случайное количество товаров от 1 до 10
        data.append((price, quantity))
    return data

# Евклидово расстояние между покупками
def euclidean_distance(purchase1, purchase2):
    return math.sqrt((purchase2[0] - purchase1[0])**2 + (purchase2[1] - purchase1[1])**2)

# k-nearest neighbors алгоритм для определения стоимости покупки
def classify_purchase(data, new_purchase, k):
    distances = [(purchase, euclidean_distance(new_purchase, purchase)) for purchase in data]
    sorted_distances = sorted(distances, key=lambda x: x[1])
    k_nearest = sorted_distances[:k]
    total_price = sum(purchase[0] for purchase, _ in k_nearest)
    average_price = total_price / k
    return "Дорогая" if average_price > 100 else "Дешевая"

# Генерируем случайные данные о покупках (1000 покупок)
data = generate_random_data(1000)

# Новая покупка, которую мы хотим классифицировать
new_purchase = (150, 5)  # стоимость 150, 5 товаров

# Определяем, является ли покупка дорогой или дешевой, используя 5 ближайших соседей
result = classify_purchase(data, new_purchase, 5)
print(f"Новая покупка является {result}.")

