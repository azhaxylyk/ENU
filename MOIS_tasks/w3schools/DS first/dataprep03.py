import pandas as pd

health_data = pd.read_csv("data01.csv", header=0, sep=",")

health_data.dropna(axis=0,inplace=True)

print(health_data)
