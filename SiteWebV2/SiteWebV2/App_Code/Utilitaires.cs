using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Description résumée de Utilitaires
/// </summary>
public class Utilitaires
{
    public float GetAutonomie(float kilo, float cout)
    {
        return (cout * 100) / kilo;
    }
}