<h1 style="color:red;">Basic Blazor Customer App</h1>

Blazor customer app is a simple client app and a .NET core 

## Features
-  Add and View Customers
-  Search for locations result using Bing Map Api

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or later with .NET 6 installed.
- An SQLite database
- [Bingo Locations Api key](https://learn.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key)
  
## Getting Started

  1.  Clone the Repository

  ```bash
  git clone https://github.com/DimitrisPOL/CustomersAndLocations-BlazorApp.git
  cd CustomersAndLocations-BlazorApp
  
  ```
2. In 'appsettings.Development.json' fill in SQLite coneection string, Bingo Locations Api key, and prefered starting point coordinates

  ```bash
    "ConnectionStrings": {
      "SQLiteDefaultConnection": "customer.db"
    },
  "BingoMapSettings": {

    "BingoLocationsApiUrl": "http://dev.virtualearth.net/",
    "BingoLocationsApiCallTemplate": "REST/v1/Autosuggest?query={0}&userLocation={1},{2}&key={3}",
    "BingoLocationsApiKey": "**************************************************",
    "BingoMapLat": "48.604311",
    "BingoMapLng": "-122.981998"
  }
  
  ```
## Images

</br>

![Screenshot 2024-08-19 at 20-22-00 Search Locations-min](https://github.com/user-attachments/assets/f7da084f-0e41-4f0e-93a9-4a4a081062c5)
</br>

![Screenshot 2024-08-19 at 20-22-58 BlazorApp-min](https://github.com/user-attachments/assets/375c695b-9f28-4085-b463-f7c37a4d66f0)
</br>
![Screenshot 2024-08-19 at 20-23-14 Customers-min](https://github.com/user-attachments/assets/f122b4df-934e-4562-8a4d-2935ab0752ba)

