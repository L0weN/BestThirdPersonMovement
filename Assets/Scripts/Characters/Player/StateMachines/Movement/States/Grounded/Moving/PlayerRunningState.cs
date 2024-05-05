using UnityEngine;
using UnityEngine.InputSystem;

namespace Mert.MovementSystem
{
    public class PlayerRunningState : PlayerMovingState
    {
        private PlayerSprintData sprintData;
        private float startTime;
        public PlayerRunningState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
            sprintData = movementData.SprintData;
        }

        #region IState Methods
        public override void Enter()
        {
            stateMachine.ReusableData.MovementSpeedModifier = movementData.RunData.SpeedModifier;

            base.Enter();

            StartAnimation(stateMachine.Player.AnimationData.RunParamaterHash);

            stateMachine.ReusableData.CurrentJumpForce = airborneData.JumpData.MediumForce;

            startTime = Time.time;
        }

        public override void Exit()
        {
            base.Exit();

            StopAnimation(stateMachine.Player.AnimationData.RunParamaterHash);
        }

        public override void Update()
        {
            base.Update();

            if (!stateMachine.ReusableData.ShouldWalk) return;

            if (Time.time < startTime + sprintData.RunToWalkTime) return;

            StopRunning();
        }
        #endregion

        #region Main Methods
        private void StopRunning()
        {
            if (stateMachine.ReusableData.MovementInput == Vector2.zero)
            {
                stateMachine.ChangeState(stateMachine.IdlingState);

                return;
            }

            stateMachine.ChangeState(stateMachine.WalkingState);
        }
        #endregion

        #region Input Methods
        protected override void OnMovementCanceled(InputAction.CallbackContext context)
        {
            stateMachine.ChangeState(stateMachine.MediumStoppingState);

            base.OnMovementCanceled(context);
        }

        protected override void OnWalkToggleStarted(InputAction.CallbackContext context)
        {
            base.OnWalkToggleStarted(context);

            stateMachine.ChangeState(stateMachine.WalkingState);
        }
        #endregion
    }
}
