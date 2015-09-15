namespace Adapter
{
    using System;

    public interface EnemyAttacker
    {
        // The target
        void FireWeapon();
        void DriveForward();
        void AssignDriver(string driverName);
    }
}