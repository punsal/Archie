using Assets.Scripts.Game_Events;
using Assets.Scripts.Machine_Events;
using Game_Events;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class CubeRotator : MonoBehaviour
    {
        public float speed = 10f;
        public bool isNear = false;

        private void OnEnable()
        {
            GameEventManager.OnIdle += Freeze;
            GameEventManager.OnGame += RotateFast;
            GameEventManager.OnExit += RotateSlow;

            InputEventManager.OnClicked += OnClicked;

        }

        private void OnDisable()
        {
            GameEventManager.OnIdle -= Freeze;
            GameEventManager.OnGame -= RotateFast;
            GameEventManager.OnExit -= RotateSlow;

            InputEventManager.OnClicked -= OnClicked;
        }

        public void RotateFast()
        {
            transform.Rotate(Vector3.up, 2f * speed * Time.deltaTime);
            transform.Rotate(Vector3.left, speed * Time.deltaTime);
        }

        public void RotateSlow()
        {
            transform.Rotate(Vector3.back, speed * Time.deltaTime);
            transform.Rotate(Vector3.right, 0.5f * speed * Time.deltaTime);
        }

        public void Freeze()
        {
            //Empty
        }

        public void OnClicked()
        {
            //Player clicked and failed?
            //not failed
            GameEventManager.RaiseOnGame(); // Spawn
            //failed
            GameEventManager.RaiseOnExit();//Game oVer!
        }
    }
}
