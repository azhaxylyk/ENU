import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.metrics import mean_squared_error
from sklearn.ensemble import GradientBoostingRegressor

df = pd.read_csv('C:/Tasbaqa/5/ENU/MOIS_tasks/10th week/sarysu_grace.csv')
df['datetime'] = pd.to_datetime(df['datetime'], format='%d/%m/%Y')
df['datetime'] = (df['datetime'] - df['datetime'].min()).dt.days

df = pd.get_dummies(df, columns=['region'], drop_first=True)
df.fillna(df.mean(), inplace=True)

X = df.drop(columns=['CSR', 'JPL', 'GFZ']) 
y = df['CSR']

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

gbm_model = GradientBoostingRegressor(n_estimators=100, learning_rate=0.1, random_state=42)
gbm_model.fit(X_train, y_train)

gbm_predictions = gbm_model.predict(X_test)
gbm_rmse = mean_squared_error(y_test, gbm_predictions, squared=False)
print(f"RMSE (Gradient Boosting - CSR): {gbm_rmse}")