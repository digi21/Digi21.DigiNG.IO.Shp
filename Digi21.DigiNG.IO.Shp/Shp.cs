﻿using Digi21.Digi3D;
using Digi21.DigiNG.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.IO.Shp
{
    public class Shp : IDrawingFile, IDisposable
    {
        public event ProgressEventHandler ProgressChanged;
        public event ResultsAddedEventHandler ResultsAdded;
        public event TaskAddedEventHandler TaskAdded;

        public Shp(string path) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab) { throw null; }
        public Shp(string path, CodePage codePage) { throw null; }
        public Shp(string path, DelegateGetWkt GetWkt) { throw null; }
        public Shp(string path, [MarshalAs(UnmanagedType.U1)] bool readOnly) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, CodePage codePage) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, [MarshalAs(UnmanagedType.U1)] bool readOnly) { throw null; }
        public Shp(string path, DelegateGetWkt GetWkt, CodePage codePage) { throw null; }
        public Shp(string path, DelegateGetWkt GetWkt, [MarshalAs(UnmanagedType.U1)] bool readOnly) { throw null; }
        public Shp(string path, [MarshalAs(UnmanagedType.U1)] bool readOnly, CodePage codePage) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, CodePage codePage) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, [MarshalAs(UnmanagedType.U1)] bool readOnly) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, [MarshalAs(UnmanagedType.U1)] bool readOnly, CodePage codePage) { throw null; }
        public Shp(string path, DelegateGetWkt GetWkt, [MarshalAs(UnmanagedType.U1)] bool readOnly, CodePage codePage) { throw null; }
        public Shp(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, [MarshalAs(UnmanagedType.U1)] bool readOnly, CodePage codePage) { throw null; }
        public ReadOnlyComplex Add(Complex complex) { throw null; }
        public void Add(Entity entity) { throw null; }
        public ReadOnlyLine Add(Line line) { throw null; }
        public ReadOnlyPoint Add(Point point) { throw null; }
        public ReadOnlyPolygon Add(Polygon polygon) { throw null; }
        public ReadOnlyText Add(Text text) { throw null; }
        public void Add(IEnumerable<Entity> entities) { throw null; }
        public void Add(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes) { throw null; }
        public void Delete(Entity entity) { throw null; }
        public void Delete(IEnumerable<Entity> entities) { throw null; }
        public void Dispose() { throw null; }
        public IDictionary<string, IDictionary<string, object>> GetDatabaseAttributes(Entity entity) { throw null; }
        public IEnumerator<Entity> GetEnumerator() { throw null; }
        IEnumerator IEnumerable.GetEnumerator() { throw null; }
        public string Wkt { get; }
        public IDictionary<string, int> DatabaseTables { get; }
        public bool CanWrite { [return: MarshalAs(UnmanagedType.U1)] get; }
        public bool CanRead { [return: MarshalAs(UnmanagedType.U1)] get; }
        public string Path { get; }
    }
}