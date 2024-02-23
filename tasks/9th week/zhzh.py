import pandas as pd
import xgboost as xgb
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score

data = {
    "Количество займов": [10, 5, 8, 12, 7, 15, 9, 11, 6, 14],
    "Длительность членства в библиотеке (в месяцах)": [24, 12, 18, 30, 15, 36, 20, 28, 14, 32],
    "Количество прочитанных книг за год": [30, 15, 25, 40, 20, 50, 35, 45, 18, 48],
    "Количество задолженностей за книги": [2, 0, 1, 3, 1, 4, 2, 3, 1, 5],
    "Будет продлевать членство в библиотеке": [1, 1, 1, 1, 0, 1, 1, 1, 0, 1]
}

df = pd.DataFrame(data)

X = df.drop("Будет продлевать членство в библиотеке", axis=1)
y = df["Будет продлевать членство в библиотеке"]

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

params = {
    "objective": "binary:logistic",
    "max_depth": 3,
    "eta": 0.1,
}

dtrain = xgb.DMatrix(X_train, label=y_train)
dtest = xgb.DMatrix(X_test, label=y_test)

num_round = 100
model = xgb.train(params, dtrain, num_round)

preds = model.predict(dtest)
threshold = 0.5
predictions = [1 if x > threshold else 0 for x in preds]
accuracy = accuracy_score(y_test, predictions)
print("Точность XGBoost для задачи предсказания продления членства в библиотеке:", accuracy)
