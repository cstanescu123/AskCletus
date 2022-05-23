export interface UserBarResponse {
ingredientsId: number
    ingredients: string
    userId: number
}

export type PostBar = Omit<UserBarResponse, "ingredientsId">;