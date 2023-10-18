import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.svm import SVC
from sklearn.metrics import accuracy_score
import time

# Создание вымышленных данных
data = pd.DataFrame({
    'Feature1': [25, 30, 22, 35, 28],  # Возраст
    'Feature2': [150, 180, 130, 165, 155],  # Давление
    'Feature3': [70, 85, 60, 75, 72],  # Пульс
    'Pregnancies': [1, 0, 1, 0, 1]  # Беременность (метка класса: 1 - беременная, 0 - не беременная)
})

# Выделение признаков и меток классов
X = data.drop("Pregnancies", axis=1)
y = data["Pregnancies"]

# Разделение данных на обучающий и тестовый наборы
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.25, random_state=42)

# Применение стандартизации данных
scaler = StandardScaler()
X_train_scaled = scaler.fit_transform(X_train)
X_test_scaled = scaler.transform(X_test)

# Обучение модели SVM
clf = SVC(kernel='linear')
start_time = time.time()
clf.fit(X_train_scaled, y_train)
end_time = time.time()

# Прогнозирование и оценка точности модели
y_pred = clf.predict(X_test_scaled)
accuracy = accuracy_score(y_test, y_pred)

print("Точность SVM:", accuracy)
print("Время обучения модели:", end_time - start_time, "секунд")
