﻿namespace Lab_1;

public class BoardBus: BoardAnyCar
{
    public BoardBus(bool driver, int passengerCount)
    {
        Driver = driver;
        PassengerCount = passengerCount;
    }
    private bool Driver { get; set; }
    private int PassengerCount { get; set; }
    public override bool BoardDriver() => Driver;
    public override int BoardPassenger() => PassengerCount;
}