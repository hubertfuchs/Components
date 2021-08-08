# EierlegendeWollmilchsau
## Softwareentwickler
- Hubert Fuchs
## 1. Problembeschreibung
Erfassung einer Reklamation im Wareneingang von einer gelieferten Bestellung mit mangelhafter Ware.
Daten | Operationen
--- | ---
Foto(Artikel, Lieferschein) | aufnehmen(Kamera), löschen
Bestellnummer(interne Nummer) | erfassen, ändern
Dokument | generieren(Foto -> Dokument)
Beschreibungstext | erfassen, ändern
Reklamation-Vorlagetext(Parameter: Beschreibungstext) | laden
Einkauf-Email-Adresse | laden aus Konfiguration
Reklamation-Betreffzeile | laden
Email(mit Dokument, Vorlagetext, Betreff, Email-Adresse) | versenden
### Anforderungen:
- ANF01: Die Daten sollen auf einem mobilen Gerät erfasst, gespeichert und versendet werden.
- ANF02: Es soll immer Offline erfasst und Online manuell versendet werden.
- ANF03: Alle Daten sollen bei der Offline-Erfassung dauerhaft gespeichert werden.
- ANF04: Nach dem erfolgreichen manuellen Online-Versand sollen die Daten gelöscht werden.
- ANF05: Die App soll Artikelfotos aufnehmen.
- ANF06: Außerdem soll die App ein Lieferscheinfoto aufnehmen.
- ANF07: Die Eingabe einer internen Bestellnummer soll möglich sein.
- ANF08: Außerdem soll die Eingabe eines manuellen Beschreibungstextes möglich sein.
- ANF09: Es soll ein gespeicherter Vorlagetext geladen werden.
- ANF10: Der Vorlagetext soll genau einen Platzhalter für den manuellen Beschreibungstext haben.
- ANF11: Die Fotos sollen in ein PDF-Dokument konvertiert werden.
- ANF12: Das PDF-Dokument soll die interne Bestellnummer als Dateinamen haben.
- ANF13: Die PDF soll als Email-Anhang verwendet werden.
- ANF14: Der zusammengeführte Text aus Vorlage und Beschreibung soll als Email-Text verwendet werden.
- ANF15: Die Email-Adresse vom Einkauf soll aus der Konfiguration gelesen werden.
- ANF16: Außerdem soll die gespeicherte Email-Betreffzeile geladen werden.
- ANF17: Das Produkt soll eine Email versenden.
## Anforderungen (ANF)
### Funktionale (FA)
- ANF01: Das Produkt soll den Saldo eines Kontos zu einem Stichtag berechnen.
- ANF02: Personen enthalten Id, Name, Alter.
- ANF03: Personen sollen nach den Kategorien Erwachsen(E) und Kind(K) ausgegeben werden.
- ANF04: Eine Altersgrenze(E/K) ist unterschiedlich nach Land.
### Nichtfunktionale (NFA)
- ANF01: Das Produkt soll dem Anwender innerhalb von einer Sekunde antworten.
- ANF02: Alle Daten sollen dauerhaft gespeichert werden.
- ANF03: Das Projekt ist potenziell langlaufend.
### Architekturtreiber/Architectural Significant Requirements(ASR)
- Erfordert einen Datenspeicher
- Anwendung muss konfigurierbar sein
- Technologien(Oberfläche, Datenbank) werden sich ändern
### Qualitätseigenschaften
- Austauschbarkeit
- Einfachheit
- Wiederverwendbarkeit
## Architekturentwurf
### Referenzarchitektur 
Composite-Component-Architecture von David Tielke / CoCo 1.0 (coming soon CoCo 2.0)
## Musterkatalog
- Komponenten
- Workflows: Verwaltung eines Geschäftsprozesses
- Management: Verwaltung einer Domäne
- DataStoring: Zugriff auf Persistenz
- DataTypes: Datenklassen
- Eigennamen zulässig
---
- Manager: Add, Remove, Update, Get*
- Repository: Insert, Update, Delete, Query
### Komponenten "schneiden"
Name | Typ | Schicht
--- | --- | ---
PersonManagement | Domänenkomponente | Logic
DataStoring | Foundationkomponente | Data
DataTypes | Domänenkomponente | CrossCutting
Configuration | Foundationskomponente | CrossCutting
... | Geschäftskomponente | ...
... | Integrationskomponente | ...