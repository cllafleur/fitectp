API
====

Afin qu'il soit plus facile pour des applications tierces d'accéder aux données de Contoso University, il a été décidé que des API devaient être implémentés.

## Story 1 - api Etudiants
### Description
L'api des étudiants doit permettre de retourner pour un étudiant données :
* Ses informations
* Les cours souscrits

#### Requête:
_Verb & URL REST:_ GET /api/students/{id}

{id}: identifiant de l'objet students en base

#### Réponse:
Le format de la réponse doit être en json et/ou xml
```json
{
    "id": 10,
    "lastname": "Alexandre",
    "firstname": "Carson",
    "enrollmentDate": "2010-09-01",
    "enrollments": [
        { "courseId": 10 },
        { "courseId": 15 }
    ]
}
```
---

## Story 2 - api professeurs
### Description
Pour les professeurs nous avons besoin d'un API pour récupérer l'agenda de la semaine.

#### Requête:
_Verb & URL REST:_ GET /api/instructors/{id}/weeklyschedule/

{id}: identifiant de l'objet instructors en base

#### Réponse:
Le format de la réponse doit être en json et/ou xml
```json
{
    "instructorId": 11,
    "schedule": [
        { "courseId": 29, "day": "wednesday", "startHour": "15h00", "duration": "60" },
        { "courseId": 22, "day": "wednesday", "startHour": "10h00", "duration": "60" },
        { "courseId": 24, "day": "friday", "startHour": "15h00", "duration": "120" }
    ]
}
```
|Fields|Format|
|-|-|
|day|Jour de la semaine en anglais, case-insensitive|
|startHour|Heure de début du cours, format de l'heure sur 24h|
|duration|Durée du cours, l'unité est la minute|

