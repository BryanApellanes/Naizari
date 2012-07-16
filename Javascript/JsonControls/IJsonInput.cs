using System;
namespace Naizari.Javascript.JsonControls
{
    interface IJsonInput
    {
        string InputJsonId { get; set; }
        bool CanEdit { get; set; }
    }
}
