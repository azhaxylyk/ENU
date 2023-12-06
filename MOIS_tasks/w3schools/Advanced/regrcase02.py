def Predict_Calorie_Burnage(Average_Pulse, Duration):
 return(3.1695 * Average_Pulse + 5.8434 * Duration - 334.5194)

print(Predict_Calorie_Burnage(110,60))
print(Predict_Calorie_Burnage(140,45))
print(Predict_Calorie_Burnage(175,20))
