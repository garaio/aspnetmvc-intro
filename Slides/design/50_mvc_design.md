!SLIDE 
# ASP.NET MVC Design #

!SLIDE bullets incremental
# Views ohne fachliche Logik #
* Die Views enthalten keinen fachlichen Code
* Die Views stellen nur "vorgekaute" Daten dar
* Views respektieren SRP/DRY durch Partial Views, wo sinnvoll

!SLIDE bullets incremental
# Views typisieren #
* Views können ein typisiertes Model entgegennehmen
* Immer ViewPage<ModelType> verwenden
* Das ermöglicht Intellisense und Compiler-Checks

!SLIDE bullets incremental
# Views: HTML Helper verwenden #
* Html.LabelFor, Html.EditorFor, Html.ValidationMessageFor etc. helfen, DRY zu bleiben
* Sauberes, einfaches HTML verwenden
* Für wiederkehrende Aufgaben eigene HtmlHelper erstellen
* Bedingungen etc. in HtmlHelper verpacken

!SLIDE bullets incremental
# Skinny Controller #
* Der Controller enthält keine fachliche Logik
* Der Controller beschafft sich seine Abhängigkeiten nicht selber
* Der Controller befasst sich nicht damit, *wie* die Daten beschafft werden
* Der Controller befasst sich nicht damit, *wie* etwas dargestellt wird

!SLIDE bullets incremental
# Controller-Actions #
* Actions sind Methoden
* Actions ergeben immer ein Result
* Actions können mit Filtern versehen werden (light-Version von AOP)
* Actions sollten einem bestimmten http-Verb zugewiesen werden

!SLIDE bullets incremental
# (Domain) Models #
* Models und andere Domain-Klassen nach SRP fein strukturieren
* Alle Business Rules etc. in Models/Domain ablegen
* Bei hoher Komplexität Command-Models verwenden

!SLIDE bullets incremental
# View Models #
* Domänenobjekte enthalten selten alle Informationen, welche die View benötigt
* ViewModels erstellen, welche die Schnittstelle zwischen Controller und View bilden

!SLIDE bullets incremental
# Command Models #
* Die eintreffenden Daten werden in einer speziellen Model-Klasse gesammelt
* Die Abhängigkeiten für die Ausführung dieser Aufgabe sind im Command Model, nicht im Controller
* Das Command Model validiert selber, ob es gültig ist
* Wenn ja, löst der Controller die Ausführung des Command Models aus

!SLIDE bullets incremental
# Das passt nicht zu MVC #
* Statische Zugriffe auf Abhängigkeiten
* Controls mit Postback-Logik

!SLIDE center
# MVC Design #
![](img/questions.jpg)
