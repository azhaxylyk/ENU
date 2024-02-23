import pandas as pd

health_data = pd.read_csv("data01.csv", header=0, sep=",")

print(health_data.head())
