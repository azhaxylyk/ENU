# Импортируем необходимые библиотеки
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.metrics import mean_squared_error
import xgboost as xgb

# Загрузка данных из CSV-файла
df = pd.read_csv('C:/Tasbaqa/5/Mathematicalfoundationsofintelligentsystems/sro/Kaz/sarysu_grace.csv')

# Преобразование столбца "datetime" в формат даты
df['datetime'] = pd.to_datetime(df['datetime'], format='%d/%m/%Y')

# Преобразование столбца "datetime" в числовой формат (количество дней с начала периода)
df['datetime'] = (df['datetime'] - df['datetime'].min()).dt.days

# Применение One-Hot Encoding к столбцу "region"
df = pd.get_dummies(df, columns=['region'], drop_first=True)

# Заполнение пропущенных значений средними значениями
df.fillna(df.mean(), inplace=True)

# Подготовка данных
X = df.drop(columns=['CSR', 'JPL', 'GFZ'])  # Исключаем целевые переменные из признаков
y = df[['CSR', 'JPL', 'GFZ']]

# Разделение данных на обучающий и тестовый наборы
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Обучение модели с использованием XGBoost
xgb_model = xgb.XGBRegressor(objective='reg:squarederror')
xgb_model.fit(X_train, y_train)

# Прогнозирование и оценка модели XGBoost
xgb_predictions = xgb_model.predict(X_test)
xgb_rmse = mean_squared_error(y_test, xgb_predictions, squared=False)
print(f"RMSE (XGBoost): {xgb_rmse}")
