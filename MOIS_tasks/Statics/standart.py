import pandas as pd
import numpy as np

full_health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data.csv", header=0, sep=",")

std = np.std(full_health_data, axis=0)

print(std)
