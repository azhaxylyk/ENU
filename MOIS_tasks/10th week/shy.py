import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.svm import SVR
from sklearn.ensemble import AdaBoostRegressor
import matplotlib.pyplot as plt

# Загрузка данных из Excel-файла
df = pd.read_excel('C:/Tasbaqa/5/Mathematicalfoundationsofintelligentsystems/sro/Kaz/12.xlsx')

# Выбор признаков и целевой переменной
X = df[['город', 'Тип места']]  # Признаки: Название города и тип места
y = df['Количество домовладений']  # Целевая переменная: Количество домохозяйств

# Преобразование категориальных признаков в числовые с помощью One-Hot Encoding
X = pd.get_dummies(X)

# Разделение данных на обучающую и тестовую выборки
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Обучение модели SVR
svm_model = SVR()
svm_model.fit(X_train, y_train)

# Оценка точности модели SVR
svm_accuracy = svm_model.score(X_test, y_test)
print(f"Точность модели SVR: {svm_accuracy}")

# Обучение модели AdaBoost
adaboost_model = AdaBoostRegressor()
adaboost_model.fit(X_train, y_train)

# Оценка точности модели AdaBoost
adaboost_accuracy = adaboost_model.score(X_test, y_test)
print(f"Точность модели AdaBoost: {adaboost_accuracy}")

# Построение графиков
plt.figure(figsize=(10, 5))

# График предсказанных значений от реальных для модели SVR
plt.subplot(1, 2, 1)
plt.scatter(y_test, svm_model.predict(X_test))
plt.xlabel('Реальные значения')
plt.ylabel('Предсказанные значения')
plt.title('SVR')

# График предсказанных значений от реальных для модели AdaBoost
plt.subplot(1, 2, 2)
plt.scatter(y_test, adaboost_model.predict(X_test))
plt.xlabel('Реальные значения')
plt.ylabel('Предсказанные значения')
plt.title('AdaBoost')

plt.tight_layout()
plt.show()