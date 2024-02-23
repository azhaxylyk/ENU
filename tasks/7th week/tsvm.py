import pandas as pd
from sklearn.model_selection import train_test_split
from tslearn.svm import TimeSeriesSVC
from sklearn.metrics import accuracy_score
import time

# Создание DataFrame с данными
data = pd.DataFrame({
    'Age': [25, 30, 22, 35, 28],  # Возраст
    'Pressure': [150, 180, 130, 165, 155],  # Давление
    'Puls': [70, 85, 60, 75, 72],  # Пульс
    'Pregnancies': [1, 0, 1, 0, 1]  # Беременность (метка класса: 1 - беременная, 0 - не беременная)
})

# Выделение признаков и меток классов
X = data.drop("Pregnancies", axis=1)
y = data["Pregnancies"]

# Разделение данных на обучающий и тестовый наборы
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.25, random_state=42)

# Инициализация и обучение модели TSVM
clf = TimeSeriesSVC(kernel="rbf")
start_time = time.time()
clf.fit(X_train, y_train)
end_time = time.time()

# Прогнозирование и оценка точности модели
y_pred = clf.predict(X_test)
accuracy = accuracy_score(y_test, y_pred)

print("Точность TSVM:", accuracy)
print("Время обучения модели:", end_time - start_time, "секунд")
