use RentaAutos;

CREATE TABLE DatosPrincipales (
    Folio INT IDENTITY(1,1) PRIMARY KEY,
    NombreAuto VARCHAR(50),
    FechaInicioRenta DATE,
    FechaEntregaRenta DATE,
    NombreCliente VARCHAR(50),
    ApellidoCliente VARCHAR(50),
    TelefonoCliente VARCHAR(20),
    DomicilioCliente VARCHAR(100)
)

