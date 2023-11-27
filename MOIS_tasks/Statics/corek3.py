#Three lines to make our compiler able to draw:
import sys
import matplotlib

import pandas as pd
import matplotlib.pyplot as plt

full_health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data.csv", header=0, sep=",")

full_health_data.plot(x ='Duration', y='Max_Pulse', kind='scatter')

plt.show()

#Two lines to make our compiler able to draw:
plt.savefig(sys.stdout.buffer)
sys.stdout.flush()
