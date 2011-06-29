!SLIDE 
# Statelessness #

!SLIDE bullets incremental
# Statelessness #
* Basis-Design von HTTP
* Jeder Request ist unabhängig
* Jeder Request muss alle erforderlichen Informationen enthalten

!SLIDE bullets incremental
# Statelessness: Grenzen #
* Viele Informationen gelten über zahlreiche Requests hinweg, z.B.
* Login-Status
* Warenkorb
* Inhalt eines Wizards

!SLIDE bullets incremental
# Statelessness: Technik #
* Das HTTP-Protokoll übermittelt bei jedem Request Informationen:
* URL
* Post-Daten (nur bei POSTs)
* Cookies
* Das gesamte State-Handling muss auf diesen Teilen aufbauen

!SLIDE bullets incremental
# State-Handling in ASP.NET MVC #
* Url
* Cookies
* Session State (?)
* Datenbank und andere Stores (?)

!SLIDE bullets incremental
# Url #
* Die Url kann in MVC frei definiert werden
* Url-Elemente sind RouteData und können von einem Request zum nächten weitergegeben werden (z.B. Sprache)
* Url ist Medium der Wahl für alles, was nicht zeitlich begrenzt oder security-relevant ist
* Erlaubt Bookmarking eines bestimmten Zustands

!SLIDE bullets incremental
# POST-Daten #
* Auch für grosse Datenmenge geeignet
* Schaffen Probleme mit dem Back-Button im Browser
* Post-Redirect-Get-Pattern

!SLIDE bullets incremental
# Cookies #
* Auf dem Client gespeichert
* Mässig sicher (manipulierbar, aber nur mit Aufwand)
* Zeitliche Begrenzung (Session oder definiert)
* Geeignet für alles, was nicht Ablauf-relevant ist
* Nur für kleine Datenmengen geeignet, da bei jedem Request übermittelt

!SLIDE bullets incremental
# Session State #
* Server-Side Datenablage
* Selektion der Session normalerweise über ein Cookie
* Heikel in Load-Balancing-Szenarien (erfordert Sticky Session oder DB-basierte Session)

!SLIDE bullets incremental
# Datenbank #
* Applikations-spezifisch
* Normalerweise nur für bestimmte, fachlich identifizierbare Sachen geeignet

!SLIDE bullets incremental
# Was wann verwenden? #
* Über Sessions hinweg speichern: Datenbank
* (unwichtige) Einstellungen: Cookie
* Login-Status, Session-Key u.ä.: Cookie (verschlüsselt)
* Alles, was Navigations-relevant ist: Url
* Datenübermittlung vom Browser: POST

!SLIDE center
# Statelessness #
![](img/questions.jpg)
