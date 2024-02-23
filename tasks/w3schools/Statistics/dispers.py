import pandas as pd
import numpy as np

health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data1.csv", header=0, sep=",")

var = np.var(health_data)

print(var)
