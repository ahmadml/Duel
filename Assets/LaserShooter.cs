using UnityEngine;

public class LaserShooter: KeyboardSpawner {
    [SerializeField] NumberField scoreField;

    protected override GameObject spawnObject() {
        GameObject newObject = base.spawnObject();  // base = super

        // Modify the text field of the new object.
        ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();
        if (newObjectScoreAdder)
            newObjectScoreAdder.SetScoreField(scoreField);

        return newObject;
    }
}
