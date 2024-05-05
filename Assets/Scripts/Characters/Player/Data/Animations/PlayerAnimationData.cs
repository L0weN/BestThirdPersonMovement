using System;
using UnityEngine;

namespace Mert.MovementSystem
{
    [Serializable]
    public class PlayerAnimationData
    {
        [Header("State Group Paramater Names")]
        [SerializeField] private string groundedParamaterName = "Grounded";
        [SerializeField] private string movingParamaterName = "Moving";
        [SerializeField] private string stoppingParamaterName = "Stopping";
        [SerializeField] private string landingParamaterName = "Landing";
        [SerializeField] private string airborneParamaterName = "Airborne";

        [Header("Grounded Paramater Names")]
        [SerializeField] private string idleParamaterName = "isIdling";
        [SerializeField] private string dashParamaterName = "isDashing";
        [SerializeField] private string walkParamaterName = "isWalking";
        [SerializeField] private string runParamaterName = "isRunning";
        [SerializeField] private string sprintParamaterName = "isSprinting";
        [SerializeField] private string mediumStopParamaterName = "isMediumStopping";
        [SerializeField] private string hardStopParamaterName = "isHardStopping";
        [SerializeField] private string rollParamaterName = "isRolling";
        [SerializeField] private string hardLandParamaterName = "isHardLanding";

        [Header("Airborne Paramater Names")]
        [SerializeField] private string fallParamaterName = "isFalling";

        public int GroundedParamaterHash { get; private set; }
        public int MovingParamaterHash { get; private set; }
        public int StoppingParamaterHash { get; private set; }
        public int LandingParamaterHash { get; private set; }
        public int AirborneParamaterHash { get; private set; }

        public int IdleParamaterHash { get; private set; }
        public int DashParamaterHash { get; private set; }
        public int WalkParamaterHash { get; private set; }
        public int RunParamaterHash { get; private set; }
        public int SprintParamaterHash { get; private set; }
        public int MediumStopParamaterHash { get; private set; }
        public int HardStopParamaterHash { get; private set; }
        public int RollParamaterHash { get; private set; }
        public int HardLandParamaterHash { get; private set; }
        public int FallParamaterHash { get; private set; }

        public void Initialize()
        {
            GroundedParamaterHash = Animator.StringToHash(groundedParamaterName);
            MovingParamaterHash = Animator.StringToHash(movingParamaterName);
            StoppingParamaterHash = Animator.StringToHash(stoppingParamaterName);
            LandingParamaterHash = Animator.StringToHash(landingParamaterName);
            AirborneParamaterHash = Animator.StringToHash(airborneParamaterName);

            IdleParamaterHash = Animator.StringToHash(idleParamaterName);
            DashParamaterHash = Animator.StringToHash(dashParamaterName);
            WalkParamaterHash = Animator.StringToHash(walkParamaterName);
            RunParamaterHash = Animator.StringToHash(runParamaterName);
            SprintParamaterHash = Animator.StringToHash(sprintParamaterName);
            MediumStopParamaterHash = Animator.StringToHash(mediumStopParamaterName);
            HardStopParamaterHash = Animator.StringToHash(hardStopParamaterName);
            RollParamaterHash = Animator.StringToHash(rollParamaterName);
            HardLandParamaterHash = Animator.StringToHash(hardLandParamaterName);
            FallParamaterHash = Animator.StringToHash(fallParamaterName);
        }
    }
}
