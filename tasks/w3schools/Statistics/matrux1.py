import pandas as pd

full_health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data.csv", header=0, sep=",")

Corr_Matrix = round(full_health_data.corr(),2)

print(Corr_Matrix)