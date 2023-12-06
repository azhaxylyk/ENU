import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns

# Установка стиля Seaborn
sns.set_style("whitegrid")

full_health_data = pd.read_csv("C:/Car/5/ENU/MOIS_tasks/Statics/data.csv", header=0, sep=",")
correlation_full_health = full_health_data.corr()

axis_corr = sns.heatmap(
    correlation_full_health,
    vmin=-1, vmax=1, center=0,
    cmap='coolwarm',  # Изменение цветовой карты
    square=True
)

plt.show()
