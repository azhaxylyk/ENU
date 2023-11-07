import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.metrics import mean_squared_error
import xgboost as xgb

df = pd.read_csv('C:/Tasbaqa/5/ENU/MOIS_tasks/10th week/sarysu_grace.csv')

df['datetime'] = pd.to_datetime(df['datetime'], format='%d/%m/%Y')
df['datetime'] = (df['datetime'] - df['datetime'].min()).dt.days

df = pd.get_dummies(df, columns=['region'], drop_first=True)
df.fillna(df.mean(), inplace=True)

X = df.drop(columns=['CSR', 'JPL', 'GFZ'])  # Исключаем целевые переменные из признаков
y = df[['CSR', 'JPL', 'GFZ']]

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

xgb_model = xgb.XGBRegressor(objective='reg:squarederror')
xgb_model.fit(X_train, y_train)

xgb_predictions = xgb_model.predict(X_test)
xgb_rmse = mean_squared_error(y_test, xgb_predictions, squared=False)
print(f"RMSE (XGBoost): {xgb_rmse}")
