# Stoppuhr-Spiel

Dies ist ein kleines Konsolen-Minispiel, das eine Stoppuhr-Funktionalität mit einer kleinen Herausforderung kombiniert: Stoppe die Zeit möglichst genau bei 10 Sekunden! Als Anfänger bekommst du einen Toleranzbereich von ±2 Sekunden. Viel Glück!

🎮 Spielidee
Der Benutzer soll versuchen, die Stoppuhr zu starten und nach genau 10 Sekunden wieder zu stoppen. Das Spiel ist eine gute Übung für das Zeitgefühl und bietet dabei eine einfache, interaktive Konsolenoberfläche.

🧩 Funktionen
Starten der Stoppuhr

Stoppen der Stoppuhr und Anzeige der verstrichenen Zeit

Zurücksetzen der Stoppuhr

🔧 Bedienung
Nach dem Start der Anwendung erscheint ein Menü:

markdown
Copy
Edit
Stopwatch Menu:
1. Start
2. Stop
3. Reset
Enter your choice (1-3):
Du kannst über die Zahlen 1–3 die jeweilige Funktion auswählen.

📦 Technische Details
Die Anwendung nutzt die System.Diagnostics.Stopwatch-Klasse, um präzise Zeitmessungen durchzuführen.

Farbige Konsolenausgaben verbessern die Benutzerfreundlichkeit.

Das Programm bleibt in einer Endlosschleife aktiv, bis es manuell beendet wird.

Eingaben werden validiert, damit nur gültige Zahlenaktionen zugelassen werden.
