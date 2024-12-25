# LogSimulatorSOC

LogSimulatorSOC est une application de simulation de g�n�ration de logs pour un Centre Op�rationnel de S�curit� (SOC). Elle utilise Serilog pour g�n�rer et enregistrer diff�rents types de logs de s�curit�.

## Pr�requis

- .NET 9
- Visual Studio 2022

## Installation

1. Clonez le d�p�t : git clone https://github.com/votre-utilisateur/LogSimulatorSOC.git

2. Ouvrez la solution dans Visual Studio 2022.

3. Assurez-vous que les packages NuGet suivants sont install�s :
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

1. Ex�cutez le projet `LogSimulatorSOC` pour d�marrer la g�n�ration de logs : dotnet run --project LogSimulatorSOC

2. L'application commencera � g�n�rer des logs et les enregistrera dans la console et dans un fichier situ� dans `logs/simulator.log`.

3. Pour arr�ter l'application, appuyez sur `Ctrl + C`.

## Structure du projet

- `LogSimulatorSOC/LogSimulatorSOC.cs` : Contient la logique principale pour la g�n�ration de logs.
- `LogSimulatorSOC.Tests/LogSimulatorSOCTest.cs` : Contient les tests unitaires pour les m�thodes de g�n�ration de logs.

## Tests

Pour ex�cuter les tests unitaires, utilisez la commande suivante : `dotnet test`

## M�thodes de g�n�ration de logs

L'application g�n�re diff�rents types de logs de s�curit� :

- `GenerateNormalSystemLog` : G�n�re un log indiquant le d�marrage r�ussi d'un processus syst�me.
- `GenerateNormalNetworkLog` : G�n�re un log indiquant l'�tablissement d'une connexion r�seau.
- `GenerateBruteForceAttemptLog` : G�n�re un log indiquant une tentative de connexion par force brute.
- `GeneratePortScanLog` : G�n�re un log indiquant une d�tection de scan de ports.
- `GenerateFraudulentSSHConnectionLog` : G�n�re un log indiquant une tentative de connexion SSH non autoris�e.

## Contribuer

Les contributions sont les bienvenues ! Veuillez soumettre une pull request ou ouvrir une issue pour discuter des changements que vous souhaitez apporter.

## Licence

Ce projet est sous licence MIT: https://opensource.org/license/mit


    

    