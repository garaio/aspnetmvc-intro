!SLIDE 
# ASP.NET MVC Design Regeln #

### GARAIO AG ###
### Leo von Wyss ###
### Senior Software Architect ###

!SLIDE bullets incremental
# Design-Ziele #
* Testbarkeit bis und mit Controller
* Wartbarkeit durch klare Code-Struktur
* OO-Prinzipien (SOLID, DRY) in der Web-Entwicklung
* Erweiterbarkeit, Flexibilität

!SLIDE bullets incremental
# Testbarkeit #
* Klassische ASP.NET-Pages und -Controls sind sehr schwer zu testen
* Abhängigkeiten müssen mit "schwerem Geschütz" wie TypeMock isoliert werden
* Datenaufbereitung und -darstellung sind oft vermischt

!SLIDE bullets incremental
# Wartbarkeit #
* Don't Repeat Yourself
* Separation of Concerns
* Single Responsibility Principle
* Kleine, fokussierte Einheiten
* Keine Magie, volle Kontrolle

!SLIDE bullets incremental
# Themen #
* SRP, DRY, KISS
* Dependency Injection
* Statelessnes
