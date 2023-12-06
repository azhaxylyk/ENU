import pandas as pd
import matplotlib.pyplot as plt

plt.style.use('ggplot')

Drowning = pd.DataFrame({
    "Drowning_Accident": [20, 40, 60, 80, 100, 120, 140, 160, 180, 200],
    "Ice_Cream_Sale": [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]
})

Drowning.plot(x="Ice_Cream_Sale", y="Drowning_Accident", kind="scatter", color='blue')

plt.show()

correlation_beach = Drowning.corr()
print(correlation_beach)
