using JayElbourneData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JayElbourneData
{
    public interface IProject
    {
        IEnumerable<Project> GetAll();
        Project GetById(int id);
        void Add(Project newProject);

        //IEnumerable<Architecture> GetAllArchitecture();
        //IEnumerable<Animation> GetAllAnimation();
        //IEnumerable<Film> GetAllFilm();
    }
}
