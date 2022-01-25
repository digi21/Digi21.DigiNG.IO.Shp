using Digi21.Digi3D;
using Digi21.DigiNG.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using Digi21.Math;
using Digi21.Tasks;

namespace Digi21.DigiNG.IO.Shp
{
    public class Shp : IDrawingFile, IDisposable
    {
        public event ProgressEventHandler ProgressChanged;
        public event ResultsAddedEventHandler ResultsAdded;
        public event TaskAddedEventHandler TaskAdded;

        public Shp(string path) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab) => throw null;
        public Shp(string path, CodePage codePage) => throw null;
        public Shp(string path, DelegateGetWkt GetWkt) => throw null;
        public Shp(string path, bool readOnly) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, CodePage codePage) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, bool readOnly) => throw null;
        public Shp(string path, DelegateGetWkt GetWkt, CodePage codePage) => throw null;
        public Shp(string path, DelegateGetWkt GetWkt, bool readOnly) => throw null;
        public Shp(string path, bool readOnly, CodePage codePage) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, CodePage codePage) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, bool readOnly) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, bool readOnly, CodePage codePage) => throw null;
        public Shp(string path, DelegateGetWkt GetWkt, bool readOnly, CodePage codePage) => throw null;
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, bool readOnly, CodePage codePage) => throw null;
        public ReadOnlyComplex Add(Complex complex) => throw null;
        public void Add(Entity entity) => throw null;
        public ReadOnlyLine Add(Line line) => throw null;
        public ReadOnlyPoint Add(Point point) => throw null;
        public ReadOnlyPolygon Add(Polygon polygon) => throw null;
        public ReadOnlyText Add(Text text) => throw null;
        public void Add(IEnumerable<Entity> entities) => throw null;
        public void Delete(Entity entity) => throw null;
        public void Delete(IEnumerable<Entity> entities) => throw null;
        public void Dispose() => throw null;
        public IEnumerator<Entity> GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;
        public string Wkt => throw null;
        public bool Visible { get => throw null; set => throw null; }
        public IDictionary<string, int> DatabaseTables => throw null;
        public bool CanWrite { get; }
        public bool CanRead { get; }
        public string Path => throw null;
        public string ConnectionString => throw null;
        public int IndexOf(Entity entity) => throw null;

        #region IWindow3D
        public Point3D W => throw null;
        public Point3D SW => throw null;
        public Point3D S => throw null;
        public Point3D SE => throw null;
        public Point3D E => throw null;
        public Point3D NE => throw null;
        public Point3D N => throw null;
        public Point3D NW => throw null;
        public Point3D Center => throw null;
        public double Depth => throw null;
        public double Height => throw null;
        public double Width => throw null;
        public bool Valid => throw null;
        public double Zmax => throw null;
        public double Ymax => throw null;
        public double Xmax => throw null;
        public double Zmin => throw null;
        public double Ymin => throw null;
        public double? Xmin => throw null;
        #endregion
    }
}

