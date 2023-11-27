#Three lines to make our compiler able to draw:
import sys
import matplotlib

import pandas as pd
import matplotlib.pyplot as plt

health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data1.csv", header=0, sep=",")

health_data.plot(x ='Average_Pulse', y='Calorie_Burnage', kind='scatter'),

plt.show()

#Two  lines to make our compiler able to draw:
plt.savefig(sys.stdout.buffer)
sys.stdout.flush()