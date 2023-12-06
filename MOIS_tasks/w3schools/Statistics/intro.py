import pandas as pd

full_health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data.csv", header=0, sep=",")

pd.set_option('display.max_columns', None)
pd.set_option('display.max_rows', None)

print(full_health_data.describe())
