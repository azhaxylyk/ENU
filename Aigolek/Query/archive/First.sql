SELECT e.Employee_ID, e.Employee_Name, p.Position_Name
FROM LibEmployees e
JOIN LibPositions p ON e.Position_ID = p.Position_ID
WHERE p.Position_Name = 'Bibliographer'