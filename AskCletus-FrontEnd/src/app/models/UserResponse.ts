export interface UserResponse {
        userId:     number
        userName:   string
        email:      string
        token:      string
    }
    
    export type PostUser = Omit<UserResponse, "userId">;