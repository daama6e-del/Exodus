using Unity.Mathematics;
using UnityEngine;

public static class ParalaxThackeryGame

{
    public enum Layer
    {
        FrontGround, MidGround, Rearground
    }

    public static float speed = 2f;

    public static float GetSpeed(Layer layer)
    {
        switch (layer)
        {
            case Layer.FrontGround:
                return speed * 100f;

            case Layer.MidGround:
                return speed * 4f;

            case Layer.Rearground:
                return speed * 1.3f;

            default:
                return speed * 8;
        }
    }
}

    public class ThackeryLevelSpeed : MonoBehaviour
    {
        public Transform[] tiles; //launching array
        public float left = -19f;
        public Vector3 right = new Vector3(19, 0f, 0f);

        public ParalaxThackeryGame.Layer layer;

        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i].position += Vector3.left * Time.deltaTime * ParalaxThackeryGame.GetSpeed(layer);

                if (tiles[i].position.x <= left)
                {
                    tiles[i].position = right;
                }
            }
        }
    }
