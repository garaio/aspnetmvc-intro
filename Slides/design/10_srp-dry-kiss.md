!SLIDE 
# SRP, DRY, KISS #

!SLIDE bullets incremental
# Single Responsibility Principle #
* Jedes "Stück Code" (Klasse, Methode)
* ...hat genau eine Aufgabe
* ...hat nur einen Grund, zu ändern
* ...kann mit einem einfachen Satz umschrieben werden

!SLIDE bullets incremental
# SRP: Typische Vermischungen #
* Berechnung und Darstellung
* Validierung, Berechnung und Persistenz
* Verschiedene Aspekte von Business Logik (z.B.&#160;Portoberechnung und Rabatte)

!SLIDE bullets incremental
# SRP: Kriterien #
* Wenn eine Klasse (oder Methode) nicht mit einem einfachen Satz beschrieben werden kann, sollte sie wahrscheinlich aufgeteilt werden
* Wenn eine Klasse bei jeder Gelegenheit wieder ändert, hat sie wohl zu viele Verantwortungen
* Klassen mit einer tiefen *coherence* (Code-Metrik) haben wahrscheinlich mehrere Verantwortungen

!SLIDE bullets incremental
# Don't Repeat Yourself #
* Copy & Paste ist nur kurzfristig gut
* Refactoring statt Copy & Paste
* Gemeinsames/gleiches hervorheben und isolieren

!SLIDE bullets incremental
# DRY und SRP #
* DRY und SRP passen gut zusammen
* SRP zwingt, grosse Blöcke aufzuteilen
* DRY zwingt, gleich/ähnlich Blöcke zusammenzufassen
* Zusammen ergibt sich das optimale Set von Klassen/Methoden

!SLIDE bullets incremental
# Keep It Simple, Stupid #
* *"Alles sollte so einfach wie möglich gemacht werden, aber nicht einfacher"* (Albert Einstein)
* Die einfachste Lösung ist die beste
* Einfach = lesbar, verständlich, wenig komplex
* Einfach != weniger Bytes Code (nur manchmal)
* Gilt für Algorithmen, aber auch Datenstrukturen

!SLIDE bullets incremental
# KISS: Optimierungen #
* Optimierungen erzeugen oft Komplexität
* Nicht auf Vorrat optimieren
* Nur gezielt optimieren, wo das Potential nachgewiesen wurde
* Einfache, elegante Lösungen sind häufig auch schneller (bzw. maschinell optimierbarer)

!SLIDE bullets incremental
# SRP/DRY/KISS: Spannungsfelder #
* Copy & Paste wäre manchmal das einfachste -- KISS und DRY abwägen
* Mehr Klassen und Methoden sind nicht einfacher -- KISS und SRP abwägen
* Tendenziell SRP, dann DRY, dann KISS

!SLIDE center
# SRP, DRY, KISS #
![](img/questions.jpg)
