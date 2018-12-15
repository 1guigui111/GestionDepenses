using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Description résumée de Utilitaires
/// </summary>
public class Utilitaires
{
    public static float GetAutonomie(float kilo, float consomme)
    {
        return (consomme * 100) / kilo;
    }
}