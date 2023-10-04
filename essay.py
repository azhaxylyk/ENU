import math

import random

def generate_random_data(num_samples):
    data = []
    for _ in range(num_samples):
        price = random.uniform(10, 200)  
        quantity = random.randint(1, 10)  
        data.append((price, quantity))
    return data

def euclidean_distance(purchase1, purchase2):
    return math.sqrt((purchase2[0] - purchase1[0])**2 + (purchase2[1] - purchase1[1])**2)

def classify_purchase(data, new_purchase, k):
    distances = [(purchase, euclidean_distance(new_purchase, purchase)) for purchase in data]
    sorted_distances = sorted(distances, key=lambda x: x[1])
    k_nearest = sorted_distances[:k]
    total_price = sum(purchase[0] for purchase, _ in k_nearest)
    average_price = total_price / k
    return "қымбат" if average_price > 100 else "арзан"

data = generate_random_data(1000)

new_purchase = (150, 5) 

result = classify_purchase(data, new_purchase, 5)
print(f"Жаңа сатып алу {result} болып табылады.")

