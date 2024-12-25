# LogSimulatorSOC

LogSimulatorSOC est une application de simulation de génération de logs pour un Centre Opérationnel de Sécurité (SOC). Elle utilise Serilog pour générer et enregistrer différents types de logs de sécurité.

## Prérequis

- .NET 9
- Visual Studio 2022

## Installation

1. Clonez le dépôt : git clone https://github.com/votre-utilisateur/LogSimulatorSOC.git

2. Ouvrez la solution dans Visual Studio 2022.

3. Assurez-vous que les packages NuGet suivants sont installés :
    - `Serilog`
    - `Serilog.Sinks.Console`
    - `Serilog.Sinks.File`
    - `xUnit` (pour les tests unitaires)

    Vous pouvez installer ces packages via la console du gestionnaire de package NuGet :
        - Install-Package Serilog
        - Install-Package Serilog.Sinks.Console
        - Install-Package Serilog.Sinks.File
        - Install-Package xUnit

## Utilisation

1. Exécutez le projet `LogSimulatorSOC` pour démarrer la génération de logs : dotnet run --project LogSimulatorSOC

2. L'application commencera à générer des logs et les enregistrera dans la console et dans un fichier situé dans `logs/simulator.log`.

3. Pour arrêter l'application, appuyez sur `Ctrl + C`.

## Structure du projet

- `LogSimulatorSOC/LogSimulatorSOC.cs` : Contient la logique principale pour la génération de logs.
- `LogSimulatorSOC.Tests/LogSimulatorSOCTest.cs` : Contient les tests unitaires pour les méthodes de génération de logs.

## Tests

Pour exécuter les tests unitaires, utilisez la commande suivante : `dotnet test`

## Méthodes de génération de logs

L'application génère différents types de logs de sécurité :

- `GenerateNormalSystemLog` : Génère un log indiquant le démarrage réussi d'un processus système.
- `GenerateNormalNetworkLog` : Génère un log indiquant l'établissement d'une connexion réseau.
- `GenerateBruteForceAttemptLog` : Génère un log indiquant une tentative de connexion par force brute.
- `GeneratePortScanLog` : Génère un log indiquant une détection de scan de ports.
- `GenerateFraudulentSSHConnectionLog` : Génère un log indiquant une tentative de connexion SSH non autorisée.

## Contribuer

Les contributions sont les bienvenues ! Veuillez soumettre une pull request ou ouvrir une issue pour discuter des changements que vous souhaitez apporter.

## Licence

Ce projet est sous licence MIT: https://opensource.org/license/mit


    

    