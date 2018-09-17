﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Core;
using Task_1;
using DataBinding.View;
using System.Windows;

namespace DataBinding.ViewModel
{
    class AnimalDetailViewModel : ViewModelBase
    {
        private Essential _essential;
        private Animal _animal;
        public Animal Animal
        {
            get
            {
                return _animal;
            }
            set
            {
                SetProperty(ref _animal, value);
            }
        }
        /// <summary>
        /// Окно детального отображения данных
        /// </summary>
        private DetailView _detailView;
        public AnimalDetailViewModel(Animal animal, Essential essential)
        {
            _detailView = new DetailView()
            {
                DataContext = this
            };
            _animal = animal;
            _cachedInsect = (Insect) _animal;
            _essential = essential;
            Squads = _essential.Load("SELECT Squad FROM CSquad").
                      Select((an) => an.Squad).ToList();
            SelectedSquad = Animal.Squad;
            _detailView.ShowDialog();
        }
        private Insect _cachedInsect;

        private SQUAD _squad;
        /// <summary>
        /// Получает/задает выбранный тип животного
        /// </summary>
        public SQUAD SelectedSquad
        {
            get
            {
                return _squad;
            }
            set
            {
                SetProperty(ref _squad, value);

                switch (_squad) {
                    case SQUAD.spiders: {
                        HideButterfly = Visibility.Collapsed;
                        HideSpider = Visibility.Visible;
                        TryChangeTypeOfAnimal(new Spider());
                        break;
                    }
                    case SQUAD.lepidoptera: {
                        HideButterfly = Visibility.Visible;
                        HideSpider = Visibility.Collapsed;
                        TryChangeTypeOfAnimal(new Butterfly());
                        break;
                    }
                }
            }
        }
        private bool TryChangeTypeOfAnimal(Insect insect)
        {
            if (_squad == _cachedInsect.Squad) {
                Animal = _cachedInsect;
                return false;
            }

            insect.Age = _cachedInsect.Age;
            insect.Feet = _cachedInsect.Feet;
            insect.ID = _cachedInsect.ID;
            insect.IsDangerous = _cachedInsect.IsDangerous;
            insect.Name = _cachedInsect.Name;
            insect.Squad = _cachedInsect.Squad;

            Animal = insect;
            return true;
        }

        private List<SQUAD> _squads;
        /// <summary>
        /// Получает/задает типы животных
        /// </summary>
        public List<SQUAD> Squads
        {
            get
            {
                return _squads;
            }
            set
            {
                SetProperty(ref _squads, value);
            }
        }
        private Visibility _hideButterfly;
        /// <summary>
        /// Управляет видимостью полей бабочки
        /// </summary>        
        public Visibility HideButterfly
        {
            get
            {
                return _hideButterfly;
            }
            set
            {
                SetProperty(ref _hideButterfly, value);
            }
        }
        private Visibility _hideSpider;
        /// <summary>
        /// Управляет видимостью полей паука
        /// </summary>
        public Visibility HideSpider
        {
            get
            {
                return _hideSpider;
            }
            set
            {
                SetProperty(ref _hideSpider, value);
            }
        }
    }
}
