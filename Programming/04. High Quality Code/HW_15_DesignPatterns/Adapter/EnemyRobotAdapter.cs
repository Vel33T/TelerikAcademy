namespace Adapter
{
    using System;

    // This is the adapter.
    public class EnemyRobotAdapter : EnemyAttacker
    {
        private EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            this.theRobot = newRobot;
        }

        public void FireWeapon()
        {
            this.theRobot.SmashWithHands();
        }

        public void DriveForward()
        {
            this.theRobot.WalkForward();
        }

        public void AssignDriver(String driverName)
        {
            this.theRobot.ReactToHuman(driverName);
        }
    }
}