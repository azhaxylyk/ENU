import pandas as pd
import statsmodels.formula.api as smf

full_health_data = pd.read_csv("data.csv", header=0, sep=",")

model = smf.ols('Calorie_Burnage ~ Average_Pulse', data = full_health_data)
results = model.fit()
print(results.summary())
