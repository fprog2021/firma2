using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using Valve.VR;
namespace Valve.VR.InteractionSystem
{

    public class go : MonoBehaviour
    {

        public SteamVR_Action_Vector2 map = SteamVR_Input.GetVector2Action("go");// объявляем используемый метод 
        public Transform cameraTransform; //объявляем публичную переменную для камеры 
        private CapsuleCollider capsol; //объявляем переменную для коллайдера нашего тела в VR
        void Start()
        {
            capsol = GetComponent<CapsuleCollider>(); // помещаем в нашу перемнную коллайдер из объекта 
        }
        void FixedUpdate()
        {
            Vector3 vaaf = Player.instance.hmdTransform.TransformDirection(map.axis.x, 0, map.axis.y); // создаем вектор, направленный в сторону наклона стика контроллера
            transform.position += Vector3.ProjectOnPlane(vaaf * Time.deltaTime * 2.0f, Vector3.up); //переносим нас на вектор парралельной плоскости нормали
            float Dflor = Vector3.Dot(cameraTransform.localPosition, Vector3.up); //расположение камеры(головы) относительно перпендикуляра, опущенного к полу 
            capsol.height = Mathf.Max(capsol.radius, Dflor);//изменяем размер коллайдера тело в зависисмости от роста человека с шлемом 
            capsol.center = cameraTransform.localPosition - 0.5f * Dflor * Vector3.up; //изменяем центр коллайдера относительно камеры(головы)
        }
    }
}



