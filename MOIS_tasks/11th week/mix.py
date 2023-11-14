import numpy as np
from sklearn.datasets import make_classification
from sklearn.model_selection import train_test_split
from sklearn.ensemble import RandomForestClassifier
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import accuracy_score

X, y = make_classification(n_samples=1000, n_features=20, random_state=42)

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3, random_state=42)

model1 = RandomForestClassifier(random_state=42)
model2 = LogisticRegression(random_state=42)

model1.fit(X_train, y_train)
model2.fit(X_train, y_train)

preds1 = model1.predict_proba(X_test)[:, 1]
preds2 = model2.predict_proba(X_test)[:, 1]

final_preds = np.round((preds1 + preds2) / 2).astype(int)

accuracy = accuracy_score(y_test, final_preds)
print(f"Точность смешанных моделей: {accuracy:.2f}")
