using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class VideoFile
    {
        string _name;
        int _duration;
        int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public int Size { get { return _duration * _quality; } }

        public override string ToString()
        {
            return $"Имя файла: {_name}, длительность: {_duration}, качество: {_quality}";
        }
    }
}
